using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MIHHLHKEFHE : IMessage<MIHHLHKEFHE>, IMessage, IEquatable<MIHHLHKEFHE>, IDeepCloneable<MIHHLHKEFHE>, IBufferMessage
{
	private static readonly MessageParser<MIHHLHKEFHE> _parser = new MessageParser<MIHHLHKEFHE>(() => new MIHHLHKEFHE());

	private UnknownFieldSet _unknownFields;

	public const int AHIFHGNPGBBFieldNumber = 6;

	private uint aHIFHGNPGBB_;

	public const int ABIMIBOPEOJFieldNumber = 12;

	private uint aBIMIBOPEOJ_;

	public const int MLHBHCHPHNDFieldNumber = 13;

	private uint mLHBHCHPHND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MIHHLHKEFHE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MIHHLHKEFHEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHIFHGNPGBB
	{
		get
		{
			return aHIFHGNPGBB_;
		}
		set
		{
			aHIFHGNPGBB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ABIMIBOPEOJ
	{
		get
		{
			return aBIMIBOPEOJ_;
		}
		set
		{
			aBIMIBOPEOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MLHBHCHPHND
	{
		get
		{
			return mLHBHCHPHND_;
		}
		set
		{
			mLHBHCHPHND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIHHLHKEFHE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIHHLHKEFHE(MIHHLHKEFHE other)
		: this()
	{
		aHIFHGNPGBB_ = other.aHIFHGNPGBB_;
		aBIMIBOPEOJ_ = other.aBIMIBOPEOJ_;
		mLHBHCHPHND_ = other.mLHBHCHPHND_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIHHLHKEFHE Clone()
	{
		return new MIHHLHKEFHE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MIHHLHKEFHE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MIHHLHKEFHE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AHIFHGNPGBB != other.AHIFHGNPGBB)
		{
			return false;
		}
		if (ABIMIBOPEOJ != other.ABIMIBOPEOJ)
		{
			return false;
		}
		if (MLHBHCHPHND != other.MLHBHCHPHND)
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
		if (AHIFHGNPGBB != 0)
		{
			num ^= AHIFHGNPGBB.GetHashCode();
		}
		if (ABIMIBOPEOJ != 0)
		{
			num ^= ABIMIBOPEOJ.GetHashCode();
		}
		if (MLHBHCHPHND != 0)
		{
			num ^= MLHBHCHPHND.GetHashCode();
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
		if (AHIFHGNPGBB != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AHIFHGNPGBB);
		}
		if (ABIMIBOPEOJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ABIMIBOPEOJ);
		}
		if (MLHBHCHPHND != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(MLHBHCHPHND);
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
		if (AHIFHGNPGBB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHIFHGNPGBB);
		}
		if (ABIMIBOPEOJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABIMIBOPEOJ);
		}
		if (MLHBHCHPHND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MLHBHCHPHND);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MIHHLHKEFHE other)
	{
		if (other != null)
		{
			if (other.AHIFHGNPGBB != 0)
			{
				AHIFHGNPGBB = other.AHIFHGNPGBB;
			}
			if (other.ABIMIBOPEOJ != 0)
			{
				ABIMIBOPEOJ = other.ABIMIBOPEOJ;
			}
			if (other.MLHBHCHPHND != 0)
			{
				MLHBHCHPHND = other.MLHBHCHPHND;
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
			case 48u:
				AHIFHGNPGBB = input.ReadUInt32();
				break;
			case 96u:
				ABIMIBOPEOJ = input.ReadUInt32();
				break;
			case 104u:
				MLHBHCHPHND = input.ReadUInt32();
				break;
			}
		}
	}
}
