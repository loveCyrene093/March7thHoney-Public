using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelChangeLineupCsReq : IMessage<ChimeraDuelChangeLineupCsReq>, IMessage, IEquatable<ChimeraDuelChangeLineupCsReq>, IDeepCloneable<ChimeraDuelChangeLineupCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDuelChangeLineupCsReq> _parser = new MessageParser<ChimeraDuelChangeLineupCsReq>(() => new ChimeraDuelChangeLineupCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GAGJAEOODEHFieldNumber = 2;

	private uint gAGJAEOODEH_;

	public const int MEKLIKLGAFIFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_mEKLIKLGAFI_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> mEKLIKLGAFI_ = new RepeatedField<uint>();

	public const int LLDNKMLIMLPFieldNumber = 14;

	private uint lLDNKMLIMLP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelChangeLineupCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelChangeLineupCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GAGJAEOODEH
	{
		get
		{
			return gAGJAEOODEH_;
		}
		set
		{
			gAGJAEOODEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MEKLIKLGAFI => mEKLIKLGAFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LLDNKMLIMLP
	{
		get
		{
			return lLDNKMLIMLP_;
		}
		set
		{
			lLDNKMLIMLP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelChangeLineupCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelChangeLineupCsReq(ChimeraDuelChangeLineupCsReq other)
		: this()
	{
		gAGJAEOODEH_ = other.gAGJAEOODEH_;
		mEKLIKLGAFI_ = other.mEKLIKLGAFI_.Clone();
		lLDNKMLIMLP_ = other.lLDNKMLIMLP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelChangeLineupCsReq Clone()
	{
		return new ChimeraDuelChangeLineupCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelChangeLineupCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelChangeLineupCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GAGJAEOODEH != other.GAGJAEOODEH)
		{
			return false;
		}
		if (!mEKLIKLGAFI_.Equals(other.mEKLIKLGAFI_))
		{
			return false;
		}
		if (LLDNKMLIMLP != other.LLDNKMLIMLP)
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
		if (GAGJAEOODEH != 0)
		{
			num ^= GAGJAEOODEH.GetHashCode();
		}
		num ^= mEKLIKLGAFI_.GetHashCode();
		if (LLDNKMLIMLP != 0)
		{
			num ^= LLDNKMLIMLP.GetHashCode();
		}
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
		if (GAGJAEOODEH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GAGJAEOODEH);
		}
		mEKLIKLGAFI_.WriteTo(ref output, _repeated_mEKLIKLGAFI_codec);
		if (LLDNKMLIMLP != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LLDNKMLIMLP);
		}
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
		if (GAGJAEOODEH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GAGJAEOODEH);
		}
		num += mEKLIKLGAFI_.CalculateSize(_repeated_mEKLIKLGAFI_codec);
		if (LLDNKMLIMLP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLDNKMLIMLP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelChangeLineupCsReq other)
	{
		if (other != null)
		{
			if (other.GAGJAEOODEH != 0)
			{
				GAGJAEOODEH = other.GAGJAEOODEH;
			}
			mEKLIKLGAFI_.Add(other.mEKLIKLGAFI_);
			if (other.LLDNKMLIMLP != 0)
			{
				LLDNKMLIMLP = other.LLDNKMLIMLP;
			}
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
			case 16u:
				GAGJAEOODEH = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				mEKLIKLGAFI_.AddEntriesFrom(ref input, _repeated_mEKLIKLGAFI_codec);
				break;
			case 112u:
				LLDNKMLIMLP = input.ReadUInt32();
				break;
			}
		}
	}
}
