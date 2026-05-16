using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UnlockBackGroundMusicCsReq : IMessage<UnlockBackGroundMusicCsReq>, IMessage, IEquatable<UnlockBackGroundMusicCsReq>, IDeepCloneable<UnlockBackGroundMusicCsReq>, IBufferMessage
{
	private static readonly MessageParser<UnlockBackGroundMusicCsReq> _parser = new MessageParser<UnlockBackGroundMusicCsReq>(() => new UnlockBackGroundMusicCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JCCOOGLCMNPFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_jCCOOGLCMNP_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> jCCOOGLCMNP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UnlockBackGroundMusicCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UnlockBackGroundMusicCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JCCOOGLCMNP => jCCOOGLCMNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockBackGroundMusicCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockBackGroundMusicCsReq(UnlockBackGroundMusicCsReq other)
		: this()
	{
		jCCOOGLCMNP_ = other.jCCOOGLCMNP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnlockBackGroundMusicCsReq Clone()
	{
		return new UnlockBackGroundMusicCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UnlockBackGroundMusicCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UnlockBackGroundMusicCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jCCOOGLCMNP_.Equals(other.jCCOOGLCMNP_))
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
		num ^= jCCOOGLCMNP_.GetHashCode();
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
		jCCOOGLCMNP_.WriteTo(ref output, _repeated_jCCOOGLCMNP_codec);
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
		num += jCCOOGLCMNP_.CalculateSize(_repeated_jCCOOGLCMNP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UnlockBackGroundMusicCsReq other)
	{
		if (other != null)
		{
			jCCOOGLCMNP_.Add(other.jCCOOGLCMNP_);
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
			if (num != 96 && num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jCCOOGLCMNP_.AddEntriesFrom(ref input, _repeated_jCCOOGLCMNP_codec);
			}
		}
	}
}
