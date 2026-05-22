using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncLineupNotify : IMessage<SyncLineupNotify>, IMessage, IEquatable<SyncLineupNotify>, IDeepCloneable<SyncLineupNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncLineupNotify> _parser = new MessageParser<SyncLineupNotify>(() => new SyncLineupNotify());

	private UnknownFieldSet _unknownFields;

	public const int LineupFieldNumber = 2;

	private LineupInfo lineup_;

	public const int ReasonListFieldNumber = 9;

	private static readonly FieldCodec<SyncLineupReason> _repeated_reasonList_codec = FieldCodec.ForEnum(74u, (SyncLineupReason x) => (int)x, (int x) => (SyncLineupReason)x);

	private readonly RepeatedField<SyncLineupReason> reasonList_ = new RepeatedField<SyncLineupReason>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncLineupNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncLineupNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupInfo Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SyncLineupReason> ReasonList => reasonList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncLineupNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncLineupNotify(SyncLineupNotify other)
		: this()
	{
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		reasonList_ = other.reasonList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncLineupNotify Clone()
	{
		return new SyncLineupNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncLineupNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncLineupNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!reasonList_.Equals(other.reasonList_))
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
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		num ^= reasonList_.GetHashCode();
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
		if (lineup_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Lineup);
		}
		reasonList_.WriteTo(ref output, _repeated_reasonList_codec);
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
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		num += reasonList_.CalculateSize(_repeated_reasonList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncLineupNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new LineupInfo();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		reasonList_.Add(other.reasonList_);
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
			case 18u:
				if (lineup_ == null)
				{
					Lineup = new LineupInfo();
				}
				input.ReadMessage(Lineup);
				break;
			case 72u:
			case 74u:
				reasonList_.AddEntriesFrom(ref input, _repeated_reasonList_codec);
				break;
			}
		}
	}
}
