using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RemoveStuffFromAreaCsReq : IMessage<RemoveStuffFromAreaCsReq>, IMessage, IEquatable<RemoveStuffFromAreaCsReq>, IDeepCloneable<RemoveStuffFromAreaCsReq>, IBufferMessage
{
	private static readonly MessageParser<RemoveStuffFromAreaCsReq> _parser = new MessageParser<RemoveStuffFromAreaCsReq>(() => new RemoveStuffFromAreaCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GKFEGIBGEGIFieldNumber = 14;

	private uint gKFEGIBGEGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RemoveStuffFromAreaCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RemoveStuffFromAreaCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKFEGIBGEGI
	{
		get
		{
			return gKFEGIBGEGI_;
		}
		set
		{
			gKFEGIBGEGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RemoveStuffFromAreaCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RemoveStuffFromAreaCsReq(RemoveStuffFromAreaCsReq other)
		: this()
	{
		gKFEGIBGEGI_ = other.gKFEGIBGEGI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RemoveStuffFromAreaCsReq Clone()
	{
		return new RemoveStuffFromAreaCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RemoveStuffFromAreaCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RemoveStuffFromAreaCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GKFEGIBGEGI != other.GKFEGIBGEGI)
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
		if (GKFEGIBGEGI != 0)
		{
			num ^= GKFEGIBGEGI.GetHashCode();
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
		if (GKFEGIBGEGI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GKFEGIBGEGI);
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
		if (GKFEGIBGEGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKFEGIBGEGI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RemoveStuffFromAreaCsReq other)
	{
		if (other != null)
		{
			if (other.GKFEGIBGEGI != 0)
			{
				GKFEGIBGEGI = other.GKFEGIBGEGI;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				GKFEGIBGEGI = input.ReadUInt32();
			}
		}
	}
}
