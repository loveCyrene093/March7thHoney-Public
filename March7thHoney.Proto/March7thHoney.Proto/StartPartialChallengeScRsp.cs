using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartPartialChallengeScRsp : IMessage<StartPartialChallengeScRsp>, IMessage, IEquatable<StartPartialChallengeScRsp>, IDeepCloneable<StartPartialChallengeScRsp>, IBufferMessage
{
	private static readonly MessageParser<StartPartialChallengeScRsp> _parser = new MessageParser<StartPartialChallengeScRsp>(() => new StartPartialChallengeScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LineupFieldNumber = 1;

	private LineupInfo lineup_;

	public const int CurChallengeFieldNumber = 6;

	private CurChallenge curChallenge_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int SceneFieldNumber = 9;

	private SceneInfo scene_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartPartialChallengeScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartPartialChallengeScRspReflection.Descriptor.MessageTypes[0];

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
	public CurChallenge CurChallenge
	{
		get
		{
			return curChallenge_;
		}
		set
		{
			curChallenge_ = value;
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
	public SceneInfo Scene
	{
		get
		{
			return scene_;
		}
		set
		{
			scene_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartPartialChallengeScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartPartialChallengeScRsp(StartPartialChallengeScRsp other)
		: this()
	{
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		curChallenge_ = ((other.curChallenge_ != null) ? other.curChallenge_.Clone() : null);
		retcode_ = other.retcode_;
		scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartPartialChallengeScRsp Clone()
	{
		return new StartPartialChallengeScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartPartialChallengeScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartPartialChallengeScRsp other)
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
		if (!object.Equals(CurChallenge, other.CurChallenge))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(Scene, other.Scene))
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
		if (curChallenge_ != null)
		{
			num ^= CurChallenge.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (scene_ != null)
		{
			num ^= Scene.GetHashCode();
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
		if (lineup_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Lineup);
		}
		if (curChallenge_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(CurChallenge);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (scene_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Scene);
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
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (curChallenge_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurChallenge);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (scene_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Scene);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartPartialChallengeScRsp other)
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
		if (other.curChallenge_ != null)
		{
			if (curChallenge_ == null)
			{
				CurChallenge = new CurChallenge();
			}
			CurChallenge.MergeFrom(other.CurChallenge);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.scene_ != null)
		{
			if (scene_ == null)
			{
				Scene = new SceneInfo();
			}
			Scene.MergeFrom(other.Scene);
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
				if (lineup_ == null)
				{
					Lineup = new LineupInfo();
				}
				input.ReadMessage(Lineup);
				break;
			case 50u:
				if (curChallenge_ == null)
				{
					CurChallenge = new CurChallenge();
				}
				input.ReadMessage(CurChallenge);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				if (scene_ == null)
				{
					Scene = new SceneInfo();
				}
				input.ReadMessage(Scene);
				break;
			}
		}
	}
}
