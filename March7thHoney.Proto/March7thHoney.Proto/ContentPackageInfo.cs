using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContentPackageInfo : IMessage<ContentPackageInfo>, IMessage, IEquatable<ContentPackageInfo>, IDeepCloneable<ContentPackageInfo>, IBufferMessage
{
	private static readonly MessageParser<ContentPackageInfo> _parser = new MessageParser<ContentPackageInfo>(() => new ContentPackageInfo());

	private UnknownFieldSet _unknownFields;

	public const int ContentIdFieldNumber = 1;

	private uint contentId_;

	public const int StatusFieldNumber = 15;

	private ContentPackageStatus status_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContentPackageInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ContentPackageInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ContentId
	{
		get
		{
			return contentId_;
		}
		set
		{
			contentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentPackageStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentPackageInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentPackageInfo(ContentPackageInfo other)
		: this()
	{
		contentId_ = other.contentId_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContentPackageInfo Clone()
	{
		return new ContentPackageInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ContentPackageInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContentPackageInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ContentId != other.ContentId)
		{
			return false;
		}
		if (Status != other.Status)
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
		if (ContentId != 0)
		{
			num ^= ContentId.GetHashCode();
		}
		if (Status != ContentPackageStatus.None)
		{
			num ^= Status.GetHashCode();
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
		if (ContentId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ContentId);
		}
		if (Status != ContentPackageStatus.None)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)Status);
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
		if (ContentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ContentId);
		}
		if (Status != ContentPackageStatus.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContentPackageInfo other)
	{
		if (other != null)
		{
			if (other.ContentId != 0)
			{
				ContentId = other.ContentId;
			}
			if (other.Status != ContentPackageStatus.None)
			{
				Status = other.Status;
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
				ContentId = input.ReadUInt32();
				break;
			case 120u:
				Status = (ContentPackageStatus)input.ReadEnum();
				break;
			}
		}
	}
}
