using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyBuildRoomScNotify : IMessage<TrainPartyBuildRoomScNotify>, IMessage, IEquatable<TrainPartyBuildRoomScNotify>, IDeepCloneable<TrainPartyBuildRoomScNotify>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyBuildRoomScNotify> _parser = new MessageParser<TrainPartyBuildRoomScNotify>(() => new TrainPartyBuildRoomScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MBIEMBJMJJNFieldNumber = 7;

	private TrainPartyInfo mBIEMBJMJJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyBuildRoomScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyBuildRoomScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyInfo MBIEMBJMJJN
	{
		get
		{
			return mBIEMBJMJJN_;
		}
		set
		{
			mBIEMBJMJJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildRoomScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildRoomScNotify(TrainPartyBuildRoomScNotify other)
		: this()
	{
		mBIEMBJMJJN_ = ((other.mBIEMBJMJJN_ != null) ? other.mBIEMBJMJJN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildRoomScNotify Clone()
	{
		return new TrainPartyBuildRoomScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyBuildRoomScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyBuildRoomScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MBIEMBJMJJN, other.MBIEMBJMJJN))
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
		if (mBIEMBJMJJN_ != null)
		{
			num ^= MBIEMBJMJJN.GetHashCode();
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
		if (mBIEMBJMJJN_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(MBIEMBJMJJN);
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
		if (mBIEMBJMJJN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MBIEMBJMJJN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyBuildRoomScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mBIEMBJMJJN_ != null)
		{
			if (mBIEMBJMJJN_ == null)
			{
				MBIEMBJMJJN = new TrainPartyInfo();
			}
			MBIEMBJMJJN.MergeFrom(other.MBIEMBJMJJN);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (mBIEMBJMJJN_ == null)
			{
				MBIEMBJMJJN = new TrainPartyInfo();
			}
			input.ReadMessage(MBIEMBJMJJN);
		}
	}
}
