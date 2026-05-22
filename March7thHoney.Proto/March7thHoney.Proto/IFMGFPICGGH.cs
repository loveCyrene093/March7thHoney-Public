using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFMGFPICGGH : IMessage<IFMGFPICGGH>, IMessage, IEquatable<IFMGFPICGGH>, IDeepCloneable<IFMGFPICGGH>, IBufferMessage
{
	private static readonly MessageParser<IFMGFPICGGH> _parser = new MessageParser<IFMGFPICGGH>(() => new IFMGFPICGGH());

	private UnknownFieldSet _unknownFields;

	public const int CountFieldNumber = 3;

	private uint count_;

	public const int BOFOOKJCJGGFieldNumber = 6;

	private uint bOFOOKJCJGG_;

	public const int NLOCDHMLGJHFieldNumber = 13;

	private uint nLOCDHMLGJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFMGFPICGGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFMGFPICGGHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public IFMGFPICGGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFMGFPICGGH(IFMGFPICGGH other)
		: this()
	{
		count_ = other.count_;
		bOFOOKJCJGG_ = other.bOFOOKJCJGG_;
		nLOCDHMLGJH_ = other.nLOCDHMLGJH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFMGFPICGGH Clone()
	{
		return new IFMGFPICGGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFMGFPICGGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFMGFPICGGH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Count != other.Count)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (BOFOOKJCJGG != 0)
		{
			num ^= BOFOOKJCJGG.GetHashCode();
		}
		if (NLOCDHMLGJH != 0)
		{
			num ^= NLOCDHMLGJH.GetHashCode();
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
		if (Count != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Count);
		}
		if (BOFOOKJCJGG != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(BOFOOKJCJGG);
		}
		if (NLOCDHMLGJH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(NLOCDHMLGJH);
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
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (BOFOOKJCJGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BOFOOKJCJGG);
		}
		if (NLOCDHMLGJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLOCDHMLGJH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFMGFPICGGH other)
	{
		if (other != null)
		{
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.BOFOOKJCJGG != 0)
			{
				BOFOOKJCJGG = other.BOFOOKJCJGG;
			}
			if (other.NLOCDHMLGJH != 0)
			{
				NLOCDHMLGJH = other.NLOCDHMLGJH;
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
			case 24u:
				Count = input.ReadUInt32();
				break;
			case 48u:
				BOFOOKJCJGG = input.ReadUInt32();
				break;
			case 104u:
				NLOCDHMLGJH = input.ReadUInt32();
				break;
			}
		}
	}
}
