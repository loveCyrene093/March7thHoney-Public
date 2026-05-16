using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MainMissionMcvSnapshot : IMessage<MainMissionMcvSnapshot>, IMessage, IEquatable<MainMissionMcvSnapshot>, IDeepCloneable<MainMissionMcvSnapshot>, IBufferMessage
{
	private static readonly MessageParser<MainMissionMcvSnapshot> _parser = new MessageParser<MainMissionMcvSnapshot>(() => new MainMissionMcvSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int MainMissionIdFieldNumber = 1;

	private uint mainMissionId_;

	public const int CustomValueListFieldNumber = 2;

	private MissionCustomValueSnapshotList customValueList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MainMissionMcvSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MainMissionMcvSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MainMissionId
	{
		get
		{
			return mainMissionId_;
		}
		set
		{
			mainMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionCustomValueSnapshotList CustomValueList
	{
		get
		{
			return customValueList_;
		}
		set
		{
			customValueList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionMcvSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionMcvSnapshot(MainMissionMcvSnapshot other)
		: this()
	{
		mainMissionId_ = other.mainMissionId_;
		customValueList_ = ((other.customValueList_ != null) ? other.customValueList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionMcvSnapshot Clone()
	{
		return new MainMissionMcvSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MainMissionMcvSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MainMissionMcvSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MainMissionId != other.MainMissionId)
		{
			return false;
		}
		if (!object.Equals(CustomValueList, other.CustomValueList))
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
		if (MainMissionId != 0)
		{
			num ^= MainMissionId.GetHashCode();
		}
		if (customValueList_ != null)
		{
			num ^= CustomValueList.GetHashCode();
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
		if (MainMissionId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MainMissionId);
		}
		if (customValueList_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(CustomValueList);
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
		if (MainMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainMissionId);
		}
		if (customValueList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CustomValueList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MainMissionMcvSnapshot other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MainMissionId != 0)
		{
			MainMissionId = other.MainMissionId;
		}
		if (other.customValueList_ != null)
		{
			if (customValueList_ == null)
			{
				CustomValueList = new MissionCustomValueSnapshotList();
			}
			CustomValueList.MergeFrom(other.CustomValueList);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				MainMissionId = input.ReadUInt32();
				break;
			case 18u:
				if (customValueList_ == null)
				{
					CustomValueList = new MissionCustomValueSnapshotList();
				}
				input.ReadMessage(CustomValueList);
				break;
			}
		}
	}
}
