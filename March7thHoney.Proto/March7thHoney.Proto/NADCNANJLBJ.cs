using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NADCNANJLBJ : IMessage<NADCNANJLBJ>, IMessage, IEquatable<NADCNANJLBJ>, IDeepCloneable<NADCNANJLBJ>, IBufferMessage
{
	private static readonly MessageParser<NADCNANJLBJ> _parser = new MessageParser<NADCNANJLBJ>(() => new NADCNANJLBJ());

	private UnknownFieldSet _unknownFields;

	public const int VisitorIdFieldNumber = 7;

	private uint visitorId_;

	public const int IsMeetFieldNumber = 13;

	private bool isMeet_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NADCNANJLBJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NADCNANJLBJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint VisitorId
	{
		get
		{
			return visitorId_;
		}
		set
		{
			visitorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsMeet
	{
		get
		{
			return isMeet_;
		}
		set
		{
			isMeet_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NADCNANJLBJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NADCNANJLBJ(NADCNANJLBJ other)
		: this()
	{
		visitorId_ = other.visitorId_;
		isMeet_ = other.isMeet_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NADCNANJLBJ Clone()
	{
		return new NADCNANJLBJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NADCNANJLBJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NADCNANJLBJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VisitorId != other.VisitorId)
		{
			return false;
		}
		if (IsMeet != other.IsMeet)
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
		if (VisitorId != 0)
		{
			num ^= VisitorId.GetHashCode();
		}
		if (IsMeet)
		{
			num ^= IsMeet.GetHashCode();
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
		if (VisitorId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(VisitorId);
		}
		if (IsMeet)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsMeet);
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
		if (VisitorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(VisitorId);
		}
		if (IsMeet)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NADCNANJLBJ other)
	{
		if (other != null)
		{
			if (other.VisitorId != 0)
			{
				VisitorId = other.VisitorId;
			}
			if (other.IsMeet)
			{
				IsMeet = other.IsMeet;
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
			case 56u:
				VisitorId = input.ReadUInt32();
				break;
			case 104u:
				IsMeet = input.ReadBool();
				break;
			}
		}
	}
}
