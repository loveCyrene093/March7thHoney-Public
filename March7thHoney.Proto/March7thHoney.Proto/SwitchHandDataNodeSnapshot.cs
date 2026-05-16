using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwitchHandDataNodeSnapshot : IMessage<SwitchHandDataNodeSnapshot>, IMessage, IEquatable<SwitchHandDataNodeSnapshot>, IDeepCloneable<SwitchHandDataNodeSnapshot>, IBufferMessage
{
	private static readonly MessageParser<SwitchHandDataNodeSnapshot> _parser = new MessageParser<SwitchHandDataNodeSnapshot>(() => new SwitchHandDataNodeSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int ConfigIdFieldNumber = 1;

	private uint configId_;

	public const int HandTransformFieldNumber = 2;

	private MotionInfoSnapshot handTransform_;

	public const int HandStateFieldNumber = 3;

	private uint handState_;

	public const int HandParamFieldNumber = 4;

	private ByteString handParam_ = ByteString.Empty;

	public const int GetCoinCountFieldNumber = 5;

	private uint getCoinCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwitchHandDataNodeSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwitchHandDataNodeSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfoSnapshot HandTransform
	{
		get
		{
			return handTransform_;
		}
		set
		{
			handTransform_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HandState
	{
		get
		{
			return handState_;
		}
		set
		{
			handState_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString HandParam
	{
		get
		{
			return handParam_;
		}
		set
		{
			handParam_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GetCoinCount
	{
		get
		{
			return getCoinCount_;
		}
		set
		{
			getCoinCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandDataNodeSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandDataNodeSnapshot(SwitchHandDataNodeSnapshot other)
		: this()
	{
		configId_ = other.configId_;
		handTransform_ = ((other.handTransform_ != null) ? other.handTransform_.Clone() : null);
		handState_ = other.handState_;
		handParam_ = other.handParam_;
		getCoinCount_ = other.getCoinCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandDataNodeSnapshot Clone()
	{
		return new SwitchHandDataNodeSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwitchHandDataNodeSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwitchHandDataNodeSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (!object.Equals(HandTransform, other.HandTransform))
		{
			return false;
		}
		if (HandState != other.HandState)
		{
			return false;
		}
		if (HandParam != other.HandParam)
		{
			return false;
		}
		if (GetCoinCount != other.GetCoinCount)
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
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (handTransform_ != null)
		{
			num ^= HandTransform.GetHashCode();
		}
		if (HandState != 0)
		{
			num ^= HandState.GetHashCode();
		}
		if (HandParam.Length != 0)
		{
			num ^= HandParam.GetHashCode();
		}
		if (GetCoinCount != 0)
		{
			num ^= GetCoinCount.GetHashCode();
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
		if (ConfigId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ConfigId);
		}
		if (handTransform_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HandTransform);
		}
		if (HandState != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HandState);
		}
		if (HandParam.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteBytes(HandParam);
		}
		if (GetCoinCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GetCoinCount);
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
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (handTransform_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HandTransform);
		}
		if (HandState != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HandState);
		}
		if (HandParam.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(HandParam);
		}
		if (GetCoinCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GetCoinCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwitchHandDataNodeSnapshot other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ConfigId != 0)
		{
			ConfigId = other.ConfigId;
		}
		if (other.handTransform_ != null)
		{
			if (handTransform_ == null)
			{
				HandTransform = new MotionInfoSnapshot();
			}
			HandTransform.MergeFrom(other.HandTransform);
		}
		if (other.HandState != 0)
		{
			HandState = other.HandState;
		}
		if (other.HandParam.Length != 0)
		{
			HandParam = other.HandParam;
		}
		if (other.GetCoinCount != 0)
		{
			GetCoinCount = other.GetCoinCount;
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
				ConfigId = input.ReadUInt32();
				break;
			case 18u:
				if (handTransform_ == null)
				{
					HandTransform = new MotionInfoSnapshot();
				}
				input.ReadMessage(HandTransform);
				break;
			case 24u:
				HandState = input.ReadUInt32();
				break;
			case 34u:
				HandParam = input.ReadBytes();
				break;
			case 40u:
				GetCoinCount = input.ReadUInt32();
				break;
			}
		}
	}
}
