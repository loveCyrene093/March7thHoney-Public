using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterSceneByServerScNotify : IMessage<EnterSceneByServerScNotify>, IMessage, IEquatable<EnterSceneByServerScNotify>, IDeepCloneable<EnterSceneByServerScNotify>, IBufferMessage
{
	private static readonly MessageParser<EnterSceneByServerScNotify> _parser = new MessageParser<EnterSceneByServerScNotify>(() => new EnterSceneByServerScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LineupFieldNumber = 3;

	private LineupInfo lineup_;

	public const int SceneFieldNumber = 9;

	private SceneInfo scene_;

	public const int ReasonFieldNumber = 12;

	private EnterSceneReason reason_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterSceneByServerScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterSceneByServerScNotifyReflection.Descriptor.MessageTypes[0];

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
	public EnterSceneReason Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSceneByServerScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSceneByServerScNotify(EnterSceneByServerScNotify other)
		: this()
	{
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
		reason_ = other.reason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSceneByServerScNotify Clone()
	{
		return new EnterSceneByServerScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterSceneByServerScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterSceneByServerScNotify other)
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
		if (!object.Equals(Scene, other.Scene))
		{
			return false;
		}
		if (Reason != other.Reason)
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
		if (scene_ != null)
		{
			num ^= Scene.GetHashCode();
		}
		if (Reason != EnterSceneReason.None)
		{
			num ^= Reason.GetHashCode();
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
			output.WriteRawTag(26);
			output.WriteMessage(Lineup);
		}
		if (scene_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Scene);
		}
		if (Reason != EnterSceneReason.None)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)Reason);
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
		if (scene_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Scene);
		}
		if (Reason != EnterSceneReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterSceneByServerScNotify other)
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
		if (other.scene_ != null)
		{
			if (scene_ == null)
			{
				Scene = new SceneInfo();
			}
			Scene.MergeFrom(other.Scene);
		}
		if (other.Reason != EnterSceneReason.None)
		{
			Reason = other.Reason;
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
			case 26u:
				if (lineup_ == null)
				{
					Lineup = new LineupInfo();
				}
				input.ReadMessage(Lineup);
				break;
			case 74u:
				if (scene_ == null)
				{
					Scene = new SceneInfo();
				}
				input.ReadMessage(Scene);
				break;
			case 96u:
				Reason = (EnterSceneReason)input.ReadEnum();
				break;
			}
		}
	}
}
