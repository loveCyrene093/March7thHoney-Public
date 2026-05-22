using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LocalLegendDataChangeNotify : IMessage<LocalLegendDataChangeNotify>, IMessage, IEquatable<LocalLegendDataChangeNotify>, IDeepCloneable<LocalLegendDataChangeNotify>, IBufferMessage
{
	private static readonly MessageParser<LocalLegendDataChangeNotify> _parser = new MessageParser<LocalLegendDataChangeNotify>(() => new LocalLegendDataChangeNotify());

	private UnknownFieldSet _unknownFields;

	public const int LevelDataFieldNumber = 14;

	private MMPJHLJHMNP levelData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LocalLegendDataChangeNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LocalLegendDataChangeNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMPJHLJHMNP LevelData
	{
		get
		{
			return levelData_;
		}
		set
		{
			levelData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LocalLegendDataChangeNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LocalLegendDataChangeNotify(LocalLegendDataChangeNotify other)
		: this()
	{
		levelData_ = ((other.levelData_ != null) ? other.levelData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LocalLegendDataChangeNotify Clone()
	{
		return new LocalLegendDataChangeNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LocalLegendDataChangeNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LocalLegendDataChangeNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LevelData, other.LevelData))
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
		if (levelData_ != null)
		{
			num ^= LevelData.GetHashCode();
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
		if (levelData_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(LevelData);
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
		if (levelData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LevelData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LocalLegendDataChangeNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.levelData_ != null)
		{
			if (levelData_ == null)
			{
				LevelData = new MMPJHLJHMNP();
			}
			LevelData.MergeFrom(other.LevelData);
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (levelData_ == null)
			{
				LevelData = new MMPJHLJHMNP();
			}
			input.ReadMessage(LevelData);
		}
	}
}
