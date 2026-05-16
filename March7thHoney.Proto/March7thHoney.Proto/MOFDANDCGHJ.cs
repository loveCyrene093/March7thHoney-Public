using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MOFDANDCGHJ : IMessage<MOFDANDCGHJ>, IMessage, IEquatable<MOFDANDCGHJ>, IDeepCloneable<MOFDANDCGHJ>, IBufferMessage
{
	private static readonly MessageParser<MOFDANDCGHJ> _parser = new MessageParser<MOFDANDCGHJ>(() => new MOFDANDCGHJ());

	private UnknownFieldSet _unknownFields;

	public const int GFIJJNNAKGPFieldNumber = 5;

	private uint gFIJJNNAKGP_;

	public const int GPEMMCMJPPDFieldNumber = 6;

	private uint gPEMMCMJPPD_;

	public const int ALFHNEHOBJAFieldNumber = 7;

	private FJDILEGCBHP aLFHNEHOBJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MOFDANDCGHJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MOFDANDCGHJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFIJJNNAKGP
	{
		get
		{
			return gFIJJNNAKGP_;
		}
		set
		{
			gFIJJNNAKGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPEMMCMJPPD
	{
		get
		{
			return gPEMMCMJPPD_;
		}
		set
		{
			gPEMMCMJPPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJDILEGCBHP ALFHNEHOBJA
	{
		get
		{
			return aLFHNEHOBJA_;
		}
		set
		{
			aLFHNEHOBJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOFDANDCGHJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOFDANDCGHJ(MOFDANDCGHJ other)
		: this()
	{
		gFIJJNNAKGP_ = other.gFIJJNNAKGP_;
		gPEMMCMJPPD_ = other.gPEMMCMJPPD_;
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOFDANDCGHJ Clone()
	{
		return new MOFDANDCGHJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MOFDANDCGHJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MOFDANDCGHJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GFIJJNNAKGP != other.GFIJJNNAKGP)
		{
			return false;
		}
		if (GPEMMCMJPPD != other.GPEMMCMJPPD)
		{
			return false;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
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
		if (GFIJJNNAKGP != 0)
		{
			num ^= GFIJJNNAKGP.GetHashCode();
		}
		if (GPEMMCMJPPD != 0)
		{
			num ^= GPEMMCMJPPD.GetHashCode();
		}
		if (ALFHNEHOBJA != FJDILEGCBHP.Pcpdhelpkem)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
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
		if (GFIJJNNAKGP != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GFIJJNNAKGP);
		}
		if (GPEMMCMJPPD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GPEMMCMJPPD);
		}
		if (ALFHNEHOBJA != FJDILEGCBHP.Pcpdhelpkem)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)ALFHNEHOBJA);
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
		if (GFIJJNNAKGP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFIJJNNAKGP);
		}
		if (GPEMMCMJPPD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPEMMCMJPPD);
		}
		if (ALFHNEHOBJA != FJDILEGCBHP.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MOFDANDCGHJ other)
	{
		if (other != null)
		{
			if (other.GFIJJNNAKGP != 0)
			{
				GFIJJNNAKGP = other.GFIJJNNAKGP;
			}
			if (other.GPEMMCMJPPD != 0)
			{
				GPEMMCMJPPD = other.GPEMMCMJPPD;
			}
			if (other.ALFHNEHOBJA != FJDILEGCBHP.Pcpdhelpkem)
			{
				ALFHNEHOBJA = other.ALFHNEHOBJA;
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
			case 40u:
				GFIJJNNAKGP = input.ReadUInt32();
				break;
			case 48u:
				GPEMMCMJPPD = input.ReadUInt32();
				break;
			case 56u:
				ALFHNEHOBJA = (FJDILEGCBHP)input.ReadEnum();
				break;
			}
		}
	}
}
