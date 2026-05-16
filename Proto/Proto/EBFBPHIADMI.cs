using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EBFBPHIADMI : IMessage<EBFBPHIADMI>, IMessage, IEquatable<EBFBPHIADMI>, IDeepCloneable<EBFBPHIADMI>, IBufferMessage
{
	private static readonly MessageParser<EBFBPHIADMI> _parser = new MessageParser<EBFBPHIADMI>(() => new EBFBPHIADMI());

	private UnknownFieldSet _unknownFields;

	public const int VisitorIdFieldNumber = 1;

	private uint visitorId_;

	public const int IsMeetFieldNumber = 2;

	private bool isMeet_;

	public const int FGCOHAAGIEGFieldNumber = 11;

	private uint fGCOHAAGIEG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EBFBPHIADMI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EBFBPHIADMIReflection.Descriptor.MessageTypes[0];

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
	public uint FGCOHAAGIEG
	{
		get
		{
			return fGCOHAAGIEG_;
		}
		set
		{
			fGCOHAAGIEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBFBPHIADMI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBFBPHIADMI(EBFBPHIADMI other)
		: this()
	{
		visitorId_ = other.visitorId_;
		isMeet_ = other.isMeet_;
		fGCOHAAGIEG_ = other.fGCOHAAGIEG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBFBPHIADMI Clone()
	{
		return new EBFBPHIADMI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EBFBPHIADMI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EBFBPHIADMI other)
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
		if (FGCOHAAGIEG != other.FGCOHAAGIEG)
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
		if (FGCOHAAGIEG != 0)
		{
			num ^= FGCOHAAGIEG.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(VisitorId);
		}
		if (IsMeet)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsMeet);
		}
		if (FGCOHAAGIEG != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FGCOHAAGIEG);
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
		if (FGCOHAAGIEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FGCOHAAGIEG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EBFBPHIADMI other)
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
			if (other.FGCOHAAGIEG != 0)
			{
				FGCOHAAGIEG = other.FGCOHAAGIEG;
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
				VisitorId = input.ReadUInt32();
				break;
			case 16u:
				IsMeet = input.ReadBool();
				break;
			case 88u:
				FGCOHAAGIEG = input.ReadUInt32();
				break;
			}
		}
	}
}
