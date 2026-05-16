using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishTutorialGuideScRsp : IMessage<FinishTutorialGuideScRsp>, IMessage, IEquatable<FinishTutorialGuideScRsp>, IDeepCloneable<FinishTutorialGuideScRsp>, IBufferMessage
{
	private static readonly MessageParser<FinishTutorialGuideScRsp> _parser = new MessageParser<FinishTutorialGuideScRsp>(() => new FinishTutorialGuideScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 1;

	private ItemList reward_;

	public const int TutorialGuideFieldNumber = 7;

	private TutorialGuide tutorialGuide_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishTutorialGuideScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishTutorialGuideScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TutorialGuide TutorialGuide
	{
		get
		{
			return tutorialGuide_;
		}
		set
		{
			tutorialGuide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTutorialGuideScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTutorialGuideScRsp(FinishTutorialGuideScRsp other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		tutorialGuide_ = ((other.tutorialGuide_ != null) ? other.tutorialGuide_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTutorialGuideScRsp Clone()
	{
		return new FinishTutorialGuideScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishTutorialGuideScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishTutorialGuideScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (!object.Equals(TutorialGuide, other.TutorialGuide))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (tutorialGuide_ != null)
		{
			num ^= TutorialGuide.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (reward_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Reward);
		}
		if (tutorialGuide_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(TutorialGuide);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
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
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (tutorialGuide_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TutorialGuide);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishTutorialGuideScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.tutorialGuide_ != null)
		{
			if (tutorialGuide_ == null)
			{
				TutorialGuide = new TutorialGuide();
			}
			TutorialGuide.MergeFrom(other.TutorialGuide);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 10u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 58u:
				if (tutorialGuide_ == null)
				{
					TutorialGuide = new TutorialGuide();
				}
				input.ReadMessage(TutorialGuide);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
