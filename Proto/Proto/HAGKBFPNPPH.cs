using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HAGKBFPNPPH : IMessage<HAGKBFPNPPH>, IMessage, IEquatable<HAGKBFPNPPH>, IDeepCloneable<HAGKBFPNPPH>, IBufferMessage
{
	private static readonly MessageParser<HAGKBFPNPPH> _parser = new MessageParser<HAGKBFPNPPH>(() => new HAGKBFPNPPH());

	private UnknownFieldSet _unknownFields;

	public const int PosFieldNumber = 1;

	private uint pos_;

	public const int BOFOOKJCJGGFieldNumber = 4;

	private uint bOFOOKJCJGG_;

	public const int NLOCDHMLGJHFieldNumber = 11;

	private uint nLOCDHMLGJH_;

	public const int CountFieldNumber = 12;

	private uint count_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HAGKBFPNPPH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HAGKBFPNPPHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BOFOOKJCJGG
	{
		get
		{
			return bOFOOKJCJGG_;
		}
		set
		{
			bOFOOKJCJGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLOCDHMLGJH
	{
		get
		{
			return nLOCDHMLGJH_;
		}
		set
		{
			nLOCDHMLGJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGKBFPNPPH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGKBFPNPPH(HAGKBFPNPPH other)
		: this()
	{
		pos_ = other.pos_;
		bOFOOKJCJGG_ = other.bOFOOKJCJGG_;
		nLOCDHMLGJH_ = other.nLOCDHMLGJH_;
		count_ = other.count_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGKBFPNPPH Clone()
	{
		return new HAGKBFPNPPH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HAGKBFPNPPH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HAGKBFPNPPH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (BOFOOKJCJGG != other.BOFOOKJCJGG)
		{
			return false;
		}
		if (NLOCDHMLGJH != other.NLOCDHMLGJH)
		{
			return false;
		}
		if (Count != other.Count)
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
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (BOFOOKJCJGG != 0)
		{
			num ^= BOFOOKJCJGG.GetHashCode();
		}
		if (NLOCDHMLGJH != 0)
		{
			num ^= NLOCDHMLGJH.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
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
		if (Pos != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Pos);
		}
		if (BOFOOKJCJGG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(BOFOOKJCJGG);
		}
		if (NLOCDHMLGJH != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(NLOCDHMLGJH);
		}
		if (Count != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Count);
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
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (BOFOOKJCJGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BOFOOKJCJGG);
		}
		if (NLOCDHMLGJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLOCDHMLGJH);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HAGKBFPNPPH other)
	{
		if (other != null)
		{
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.BOFOOKJCJGG != 0)
			{
				BOFOOKJCJGG = other.BOFOOKJCJGG;
			}
			if (other.NLOCDHMLGJH != 0)
			{
				NLOCDHMLGJH = other.NLOCDHMLGJH;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
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
				Pos = input.ReadUInt32();
				break;
			case 32u:
				BOFOOKJCJGG = input.ReadUInt32();
				break;
			case 88u:
				NLOCDHMLGJH = input.ReadUInt32();
				break;
			case 96u:
				Count = input.ReadUInt32();
				break;
			}
		}
	}
}
