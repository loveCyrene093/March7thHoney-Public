using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightEliteBranchActionInfo : IMessage<GridFightEliteBranchActionInfo>, IMessage, IEquatable<GridFightEliteBranchActionInfo>, IDeepCloneable<GridFightEliteBranchActionInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightEliteBranchActionInfo> _parser = new MessageParser<GridFightEliteBranchActionInfo>(() => new GridFightEliteBranchActionInfo());

	private UnknownFieldSet _unknownFields;

	public const int EOOPOFCCHAAFieldNumber = 9;

	private uint eOOPOFCCHAA_;

	public const int FCHPJKAIBHBFieldNumber = 10;

	private uint fCHPJKAIBHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightEliteBranchActionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightEliteBranchActionInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EOOPOFCCHAA
	{
		get
		{
			return eOOPOFCCHAA_;
		}
		set
		{
			eOOPOFCCHAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCHPJKAIBHB
	{
		get
		{
			return fCHPJKAIBHB_;
		}
		set
		{
			fCHPJKAIBHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEliteBranchActionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEliteBranchActionInfo(GridFightEliteBranchActionInfo other)
		: this()
	{
		eOOPOFCCHAA_ = other.eOOPOFCCHAA_;
		fCHPJKAIBHB_ = other.fCHPJKAIBHB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEliteBranchActionInfo Clone()
	{
		return new GridFightEliteBranchActionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightEliteBranchActionInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightEliteBranchActionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EOOPOFCCHAA != other.EOOPOFCCHAA)
		{
			return false;
		}
		if (FCHPJKAIBHB != other.FCHPJKAIBHB)
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
		if (EOOPOFCCHAA != 0)
		{
			num ^= EOOPOFCCHAA.GetHashCode();
		}
		if (FCHPJKAIBHB != 0)
		{
			num ^= FCHPJKAIBHB.GetHashCode();
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
		if (EOOPOFCCHAA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EOOPOFCCHAA);
		}
		if (FCHPJKAIBHB != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(FCHPJKAIBHB);
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
		if (EOOPOFCCHAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EOOPOFCCHAA);
		}
		if (FCHPJKAIBHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCHPJKAIBHB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightEliteBranchActionInfo other)
	{
		if (other != null)
		{
			if (other.EOOPOFCCHAA != 0)
			{
				EOOPOFCCHAA = other.EOOPOFCCHAA;
			}
			if (other.FCHPJKAIBHB != 0)
			{
				FCHPJKAIBHB = other.FCHPJKAIBHB;
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
			case 72u:
				EOOPOFCCHAA = input.ReadUInt32();
				break;
			case 80u:
				FCHPJKAIBHB = input.ReadUInt32();
				break;
			}
		}
	}
}
