using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyBuildSelfDisplayAreaDiyScNotify : IMessage<TrainPartyBuildSelfDisplayAreaDiyScNotify>, IMessage, IEquatable<TrainPartyBuildSelfDisplayAreaDiyScNotify>, IDeepCloneable<TrainPartyBuildSelfDisplayAreaDiyScNotify>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyBuildSelfDisplayAreaDiyScNotify> _parser = new MessageParser<TrainPartyBuildSelfDisplayAreaDiyScNotify>(() => new TrainPartyBuildSelfDisplayAreaDiyScNotify());

	private UnknownFieldSet _unknownFields;

	public const int TrainPartyDataFieldNumber = 12;

	private TrainPartyInfo trainPartyData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyBuildSelfDisplayAreaDiyScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyBuildSelfDisplayAreaDiyScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyInfo TrainPartyData
	{
		get
		{
			return trainPartyData_;
		}
		set
		{
			trainPartyData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildSelfDisplayAreaDiyScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildSelfDisplayAreaDiyScNotify(TrainPartyBuildSelfDisplayAreaDiyScNotify other)
		: this()
	{
		trainPartyData_ = ((other.trainPartyData_ != null) ? other.trainPartyData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildSelfDisplayAreaDiyScNotify Clone()
	{
		return new TrainPartyBuildSelfDisplayAreaDiyScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyBuildSelfDisplayAreaDiyScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyBuildSelfDisplayAreaDiyScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(TrainPartyData, other.TrainPartyData))
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
		if (trainPartyData_ != null)
		{
			num ^= TrainPartyData.GetHashCode();
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
		if (trainPartyData_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(TrainPartyData);
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
		if (trainPartyData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TrainPartyData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyBuildSelfDisplayAreaDiyScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.trainPartyData_ != null)
		{
			if (trainPartyData_ == null)
			{
				TrainPartyData = new TrainPartyInfo();
			}
			TrainPartyData.MergeFrom(other.TrainPartyData);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (trainPartyData_ == null)
			{
				TrainPartyData = new TrainPartyInfo();
			}
			input.ReadMessage(TrainPartyData);
		}
	}
}
