using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LCFDGFOCHOJ : IMessage<LCFDGFOCHOJ>, IMessage, IEquatable<LCFDGFOCHOJ>, IDeepCloneable<LCFDGFOCHOJ>, IBufferMessage
{
	private static readonly MessageParser<LCFDGFOCHOJ> _parser = new MessageParser<LCFDGFOCHOJ>(() => new LCFDGFOCHOJ());

	private UnknownFieldSet _unknownFields;

	public const int DBAEAHBAJPMFieldNumber = 2;

	private static readonly FieldCodec<BAHKPEGINBB> _repeated_dBAEAHBAJPM_codec = FieldCodec.ForMessage(18u, BAHKPEGINBB.Parser);

	private readonly RepeatedField<BAHKPEGINBB> dBAEAHBAJPM_ = new RepeatedField<BAHKPEGINBB>();

	public const int GOCFKLKHBDFFieldNumber = 6;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_gOCFKLKHBDF_codec = FieldCodec.ForMessage(50u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> gOCFKLKHBDF_ = new RepeatedField<GKDEKJKOIJN>();

	public const int HJKAPBEMEOOFieldNumber = 11;

	private ulong hJKAPBEMEOO_;

	public const int AvatarListFieldNumber = 12;

	private static readonly FieldCodec<OMPODELCHFD> _repeated_avatarList_codec = FieldCodec.ForMessage(98u, OMPODELCHFD.Parser);

	private readonly RepeatedField<OMPODELCHFD> avatarList_ = new RepeatedField<OMPODELCHFD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LCFDGFOCHOJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LCFDGFOCHOJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BAHKPEGINBB> DBAEAHBAJPM => dBAEAHBAJPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> GOCFKLKHBDF => gOCFKLKHBDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong HJKAPBEMEOO
	{
		get
		{
			return hJKAPBEMEOO_;
		}
		set
		{
			hJKAPBEMEOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OMPODELCHFD> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCFDGFOCHOJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCFDGFOCHOJ(LCFDGFOCHOJ other)
		: this()
	{
		dBAEAHBAJPM_ = other.dBAEAHBAJPM_.Clone();
		gOCFKLKHBDF_ = other.gOCFKLKHBDF_.Clone();
		hJKAPBEMEOO_ = other.hJKAPBEMEOO_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCFDGFOCHOJ Clone()
	{
		return new LCFDGFOCHOJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LCFDGFOCHOJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LCFDGFOCHOJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dBAEAHBAJPM_.Equals(other.dBAEAHBAJPM_))
		{
			return false;
		}
		if (!gOCFKLKHBDF_.Equals(other.gOCFKLKHBDF_))
		{
			return false;
		}
		if (HJKAPBEMEOO != other.HJKAPBEMEOO)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		num ^= dBAEAHBAJPM_.GetHashCode();
		num ^= gOCFKLKHBDF_.GetHashCode();
		if (HJKAPBEMEOO != 0L)
		{
			num ^= HJKAPBEMEOO.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		dBAEAHBAJPM_.WriteTo(ref output, _repeated_dBAEAHBAJPM_codec);
		gOCFKLKHBDF_.WriteTo(ref output, _repeated_gOCFKLKHBDF_codec);
		if (HJKAPBEMEOO != 0L)
		{
			output.WriteRawTag(88);
			output.WriteUInt64(HJKAPBEMEOO);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		num += dBAEAHBAJPM_.CalculateSize(_repeated_dBAEAHBAJPM_codec);
		num += gOCFKLKHBDF_.CalculateSize(_repeated_gOCFKLKHBDF_codec);
		if (HJKAPBEMEOO != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(HJKAPBEMEOO);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LCFDGFOCHOJ other)
	{
		if (other != null)
		{
			dBAEAHBAJPM_.Add(other.dBAEAHBAJPM_);
			gOCFKLKHBDF_.Add(other.gOCFKLKHBDF_);
			if (other.HJKAPBEMEOO != 0L)
			{
				HJKAPBEMEOO = other.HJKAPBEMEOO;
			}
			avatarList_.Add(other.avatarList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
				dBAEAHBAJPM_.AddEntriesFrom(ref input, _repeated_dBAEAHBAJPM_codec);
				break;
			case 50u:
				gOCFKLKHBDF_.AddEntriesFrom(ref input, _repeated_gOCFKLKHBDF_codec);
				break;
			case 88u:
				HJKAPBEMEOO = input.ReadUInt64();
				break;
			case 98u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
