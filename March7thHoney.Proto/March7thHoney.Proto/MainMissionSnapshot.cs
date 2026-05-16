using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MainMissionSnapshot : IMessage<MainMissionSnapshot>, IMessage, IEquatable<MainMissionSnapshot>, IDeepCloneable<MainMissionSnapshot>, IBufferMessage
{
	private static readonly MessageParser<MainMissionSnapshot> _parser = new MessageParser<MainMissionSnapshot>(() => new MainMissionSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int MainMissionIdFieldNumber = 1;

	private uint mainMissionId_;

	public const int SubMissionListFieldNumber = 2;

	private static readonly FieldCodec<SubMissionSnapshot> _repeated_subMissionList_codec = FieldCodec.ForMessage(18u, SubMissionSnapshot.Parser);

	private readonly RepeatedField<SubMissionSnapshot> subMissionList_ = new RepeatedField<SubMissionSnapshot>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MainMissionSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MainMissionSnapshotReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<SubMissionSnapshot> SubMissionList => subMissionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionSnapshot(MainMissionSnapshot other)
		: this()
	{
		mainMissionId_ = other.mainMissionId_;
		subMissionList_ = other.subMissionList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionSnapshot Clone()
	{
		return new MainMissionSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MainMissionSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MainMissionSnapshot other)
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
		if (!subMissionList_.Equals(other.subMissionList_))
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
		num ^= subMissionList_.GetHashCode();
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
		subMissionList_.WriteTo(ref output, _repeated_subMissionList_codec);
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
		num += subMissionList_.CalculateSize(_repeated_subMissionList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MainMissionSnapshot other)
	{
		if (other != null)
		{
			if (other.MainMissionId != 0)
			{
				MainMissionId = other.MainMissionId;
			}
			subMissionList_.Add(other.subMissionList_);
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
				MainMissionId = input.ReadUInt32();
				break;
			case 18u:
				subMissionList_.AddEntriesFrom(ref input, _repeated_subMissionList_codec);
				break;
			}
		}
	}
}
