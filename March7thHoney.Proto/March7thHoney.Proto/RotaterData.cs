using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RotaterData : IMessage<RotaterData>, IMessage, IEquatable<RotaterData>, IDeepCloneable<RotaterData>, IBufferMessage
{
	private static readonly MessageParser<RotaterData> _parser = new MessageParser<RotaterData>(() => new RotaterData());

	private UnknownFieldSet _unknownFields;

	public const int MBAFIOCLMAIFieldNumber = 5;

	private float mBAFIOCLMAI_;

	public const int GroupIdFieldNumber = 9;

	private uint groupId_;

	public const int PBOLMBLKDNDFieldNumber = 14;

	private uint pBOLMBLKDND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RotaterData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RotaterDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float MBAFIOCLMAI
	{
		get
		{
			return mBAFIOCLMAI_;
		}
		set
		{
			mBAFIOCLMAI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PBOLMBLKDND
	{
		get
		{
			return pBOLMBLKDND_;
		}
		set
		{
			pBOLMBLKDND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterData(RotaterData other)
		: this()
	{
		mBAFIOCLMAI_ = other.mBAFIOCLMAI_;
		groupId_ = other.groupId_;
		pBOLMBLKDND_ = other.pBOLMBLKDND_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterData Clone()
	{
		return new RotaterData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RotaterData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RotaterData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MBAFIOCLMAI, other.MBAFIOCLMAI))
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (PBOLMBLKDND != other.PBOLMBLKDND)
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
		if (MBAFIOCLMAI != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MBAFIOCLMAI);
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (PBOLMBLKDND != 0)
		{
			num ^= PBOLMBLKDND.GetHashCode();
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
		if (MBAFIOCLMAI != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(MBAFIOCLMAI);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GroupId);
		}
		if (PBOLMBLKDND != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PBOLMBLKDND);
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
		if (MBAFIOCLMAI != 0f)
		{
			num += 5;
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (PBOLMBLKDND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PBOLMBLKDND);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RotaterData other)
	{
		if (other != null)
		{
			if (other.MBAFIOCLMAI != 0f)
			{
				MBAFIOCLMAI = other.MBAFIOCLMAI;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.PBOLMBLKDND != 0)
			{
				PBOLMBLKDND = other.PBOLMBLKDND;
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
			case 45u:
				MBAFIOCLMAI = input.ReadFloat();
				break;
			case 72u:
				GroupId = input.ReadUInt32();
				break;
			case 112u:
				PBOLMBLKDND = input.ReadUInt32();
				break;
			}
		}
	}
}
