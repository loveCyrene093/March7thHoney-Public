using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PGPELNFKOMD : IMessage<PGPELNFKOMD>, IMessage, IEquatable<PGPELNFKOMD>, IDeepCloneable<PGPELNFKOMD>, IBufferMessage
{
	private static readonly MessageParser<PGPELNFKOMD> _parser = new MessageParser<PGPELNFKOMD>(() => new PGPELNFKOMD());

	private UnknownFieldSet _unknownFields;

	public const int HJMGGLANHMLFieldNumber = 1;

	private uint hJMGGLANHML_;

	public const int MDFDBACCFOHFieldNumber = 2;

	private double mDFDBACCFOH_;

	public const int EEHJPPLINAEFieldNumber = 3;

	private uint eEHJPPLINAE_;

	public const int BreakTimesFieldNumber = 4;

	private uint breakTimes_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PGPELNFKOMD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PGPELNFKOMDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJMGGLANHML
	{
		get
		{
			return hJMGGLANHML_;
		}
		set
		{
			hJMGGLANHML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MDFDBACCFOH
	{
		get
		{
			return mDFDBACCFOH_;
		}
		set
		{
			mDFDBACCFOH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EEHJPPLINAE
	{
		get
		{
			return eEHJPPLINAE_;
		}
		set
		{
			eEHJPPLINAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BreakTimes
	{
		get
		{
			return breakTimes_;
		}
		set
		{
			breakTimes_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGPELNFKOMD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGPELNFKOMD(PGPELNFKOMD other)
		: this()
	{
		hJMGGLANHML_ = other.hJMGGLANHML_;
		mDFDBACCFOH_ = other.mDFDBACCFOH_;
		eEHJPPLINAE_ = other.eEHJPPLINAE_;
		breakTimes_ = other.breakTimes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGPELNFKOMD Clone()
	{
		return new PGPELNFKOMD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PGPELNFKOMD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PGPELNFKOMD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HJMGGLANHML != other.HJMGGLANHML)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MDFDBACCFOH, other.MDFDBACCFOH))
		{
			return false;
		}
		if (EEHJPPLINAE != other.EEHJPPLINAE)
		{
			return false;
		}
		if (BreakTimes != other.BreakTimes)
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
		if (HJMGGLANHML != 0)
		{
			num ^= HJMGGLANHML.GetHashCode();
		}
		if (MDFDBACCFOH != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MDFDBACCFOH);
		}
		if (EEHJPPLINAE != 0)
		{
			num ^= EEHJPPLINAE.GetHashCode();
		}
		if (BreakTimes != 0)
		{
			num ^= BreakTimes.GetHashCode();
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
		if (HJMGGLANHML != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HJMGGLANHML);
		}
		if (MDFDBACCFOH != 0.0)
		{
			output.WriteRawTag(17);
			output.WriteDouble(MDFDBACCFOH);
		}
		if (EEHJPPLINAE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EEHJPPLINAE);
		}
		if (BreakTimes != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BreakTimes);
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
		if (HJMGGLANHML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJMGGLANHML);
		}
		if (MDFDBACCFOH != 0.0)
		{
			num += 9;
		}
		if (EEHJPPLINAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EEHJPPLINAE);
		}
		if (BreakTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BreakTimes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PGPELNFKOMD other)
	{
		if (other != null)
		{
			if (other.HJMGGLANHML != 0)
			{
				HJMGGLANHML = other.HJMGGLANHML;
			}
			if (other.MDFDBACCFOH != 0.0)
			{
				MDFDBACCFOH = other.MDFDBACCFOH;
			}
			if (other.EEHJPPLINAE != 0)
			{
				EEHJPPLINAE = other.EEHJPPLINAE;
			}
			if (other.BreakTimes != 0)
			{
				BreakTimes = other.BreakTimes;
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
			case 8u:
				HJMGGLANHML = input.ReadUInt32();
				break;
			case 17u:
				MDFDBACCFOH = input.ReadDouble();
				break;
			case 24u:
				EEHJPPLINAE = input.ReadUInt32();
				break;
			case 32u:
				BreakTimes = input.ReadUInt32();
				break;
			}
		}
	}
}
