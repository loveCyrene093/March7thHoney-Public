using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KJGMAEGNBKL : IMessage<KJGMAEGNBKL>, IMessage, IEquatable<KJGMAEGNBKL>, IDeepCloneable<KJGMAEGNBKL>, IBufferMessage
{
	private static readonly MessageParser<KJGMAEGNBKL> _parser = new MessageParser<KJGMAEGNBKL>(() => new KJGMAEGNBKL());

	private UnknownFieldSet _unknownFields;

	public const int JDBOIHJHEHPFieldNumber = 2;

	private static readonly FieldCodec<AreaDynamicInfo> _repeated_jDBOIHJHEHP_codec = FieldCodec.ForMessage(18u, AreaDynamicInfo.Parser);

	private readonly RepeatedField<AreaDynamicInfo> jDBOIHJHEHP_ = new RepeatedField<AreaDynamicInfo>();

	public const int NMLANPJGJFAFieldNumber = 4;

	private static readonly FieldCodec<LMHFOFIEIMN> _repeated_nMLANPJGJFA_codec = FieldCodec.ForMessage(34u, LMHFOFIEIMN.Parser);

	private readonly RepeatedField<LMHFOFIEIMN> nMLANPJGJFA_ = new RepeatedField<LMHFOFIEIMN>();

	public const int IDPHCKABBJMFieldNumber = 9;

	private static readonly FieldCodec<IOBBILGOFCL> _repeated_iDPHCKABBJM_codec = FieldCodec.ForMessage(74u, IOBBILGOFCL.Parser);

	private readonly RepeatedField<IOBBILGOFCL> iDPHCKABBJM_ = new RepeatedField<IOBBILGOFCL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KJGMAEGNBKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KJGMAEGNBKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AreaDynamicInfo> JDBOIHJHEHP => jDBOIHJHEHP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LMHFOFIEIMN> NMLANPJGJFA => nMLANPJGJFA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IOBBILGOFCL> IDPHCKABBJM => iDPHCKABBJM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJGMAEGNBKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJGMAEGNBKL(KJGMAEGNBKL other)
		: this()
	{
		jDBOIHJHEHP_ = other.jDBOIHJHEHP_.Clone();
		nMLANPJGJFA_ = other.nMLANPJGJFA_.Clone();
		iDPHCKABBJM_ = other.iDPHCKABBJM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJGMAEGNBKL Clone()
	{
		return new KJGMAEGNBKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KJGMAEGNBKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KJGMAEGNBKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jDBOIHJHEHP_.Equals(other.jDBOIHJHEHP_))
		{
			return false;
		}
		if (!nMLANPJGJFA_.Equals(other.nMLANPJGJFA_))
		{
			return false;
		}
		if (!iDPHCKABBJM_.Equals(other.iDPHCKABBJM_))
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
		num ^= jDBOIHJHEHP_.GetHashCode();
		num ^= nMLANPJGJFA_.GetHashCode();
		num ^= iDPHCKABBJM_.GetHashCode();
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
		jDBOIHJHEHP_.WriteTo(ref output, _repeated_jDBOIHJHEHP_codec);
		nMLANPJGJFA_.WriteTo(ref output, _repeated_nMLANPJGJFA_codec);
		iDPHCKABBJM_.WriteTo(ref output, _repeated_iDPHCKABBJM_codec);
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
		num += jDBOIHJHEHP_.CalculateSize(_repeated_jDBOIHJHEHP_codec);
		num += nMLANPJGJFA_.CalculateSize(_repeated_nMLANPJGJFA_codec);
		num += iDPHCKABBJM_.CalculateSize(_repeated_iDPHCKABBJM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KJGMAEGNBKL other)
	{
		if (other != null)
		{
			jDBOIHJHEHP_.Add(other.jDBOIHJHEHP_);
			nMLANPJGJFA_.Add(other.nMLANPJGJFA_);
			iDPHCKABBJM_.Add(other.iDPHCKABBJM_);
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
				jDBOIHJHEHP_.AddEntriesFrom(ref input, _repeated_jDBOIHJHEHP_codec);
				break;
			case 34u:
				nMLANPJGJFA_.AddEntriesFrom(ref input, _repeated_nMLANPJGJFA_codec);
				break;
			case 74u:
				iDPHCKABBJM_.AddEntriesFrom(ref input, _repeated_iDPHCKABBJM_codec);
				break;
			}
		}
	}
}
