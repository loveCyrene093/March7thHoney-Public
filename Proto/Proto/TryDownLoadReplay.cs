using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TryDownLoadReplay : IMessage<TryDownLoadReplay>, IMessage, IEquatable<TryDownLoadReplay>, IDeepCloneable<TryDownLoadReplay>, IBufferMessage
{
	private static readonly MessageParser<TryDownLoadReplay> _parser = new MessageParser<TryDownLoadReplay>(() => new TryDownLoadReplay());

	private UnknownFieldSet _unknownFields;

	public const int ReplayNameFieldNumber = 1;

	private string replayName_ = "";

	public const int TryDownLoadReplay_FieldNumber = 2;

	private ReplayInfo tryDownLoadReplay_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TryDownLoadReplay> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TryDownLoadReplayReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ReplayName
	{
		get
		{
			return replayName_;
		}
		set
		{
			replayName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReplayInfo TryDownLoadReplay_
	{
		get
		{
			return tryDownLoadReplay_;
		}
		set
		{
			tryDownLoadReplay_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TryDownLoadReplay()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TryDownLoadReplay(TryDownLoadReplay other)
		: this()
	{
		replayName_ = other.replayName_;
		tryDownLoadReplay_ = ((other.tryDownLoadReplay_ != null) ? other.tryDownLoadReplay_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TryDownLoadReplay Clone()
	{
		return new TryDownLoadReplay(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TryDownLoadReplay);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TryDownLoadReplay other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ReplayName != other.ReplayName)
		{
			return false;
		}
		if (!object.Equals(TryDownLoadReplay_, other.TryDownLoadReplay_))
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
		if (ReplayName.Length != 0)
		{
			num ^= ReplayName.GetHashCode();
		}
		if (tryDownLoadReplay_ != null)
		{
			num ^= TryDownLoadReplay_.GetHashCode();
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
		if (ReplayName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ReplayName);
		}
		if (tryDownLoadReplay_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(TryDownLoadReplay_);
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
		if (ReplayName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ReplayName);
		}
		if (tryDownLoadReplay_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TryDownLoadReplay_);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TryDownLoadReplay other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ReplayName.Length != 0)
		{
			ReplayName = other.ReplayName;
		}
		if (other.tryDownLoadReplay_ != null)
		{
			if (tryDownLoadReplay_ == null)
			{
				TryDownLoadReplay_ = new ReplayInfo();
			}
			TryDownLoadReplay_.MergeFrom(other.TryDownLoadReplay_);
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
				ReplayName = input.ReadString();
				break;
			case 18u:
				if (tryDownLoadReplay_ == null)
				{
					TryDownLoadReplay_ = new ReplayInfo();
				}
				input.ReadMessage(TryDownLoadReplay_);
				break;
			}
		}
	}
}
