using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnteredSceneChangeScNotify : IMessage<EnteredSceneChangeScNotify>, IMessage, IEquatable<EnteredSceneChangeScNotify>, IDeepCloneable<EnteredSceneChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<EnteredSceneChangeScNotify> _parser = new MessageParser<EnteredSceneChangeScNotify>(() => new EnteredSceneChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int EnteredSceneInfoListFieldNumber = 4;

	private static readonly FieldCodec<EnteredSceneInfo> _repeated_enteredSceneInfoList_codec = FieldCodec.ForMessage(34u, EnteredSceneInfo.Parser);

	private readonly RepeatedField<EnteredSceneInfo> enteredSceneInfoList_ = new RepeatedField<EnteredSceneInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnteredSceneChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnteredSceneChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EnteredSceneInfo> EnteredSceneInfoList => enteredSceneInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnteredSceneChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnteredSceneChangeScNotify(EnteredSceneChangeScNotify other)
		: this()
	{
		enteredSceneInfoList_ = other.enteredSceneInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnteredSceneChangeScNotify Clone()
	{
		return new EnteredSceneChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnteredSceneChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnteredSceneChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!enteredSceneInfoList_.Equals(other.enteredSceneInfoList_))
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
		num ^= enteredSceneInfoList_.GetHashCode();
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
		enteredSceneInfoList_.WriteTo(ref output, _repeated_enteredSceneInfoList_codec);
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
		num += enteredSceneInfoList_.CalculateSize(_repeated_enteredSceneInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnteredSceneChangeScNotify other)
	{
		if (other != null)
		{
			enteredSceneInfoList_.Add(other.enteredSceneInfoList_);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				enteredSceneInfoList_.AddEntriesFrom(ref input, _repeated_enteredSceneInfoList_codec);
			}
		}
	}
}
