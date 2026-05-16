using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSceneMapInfoCsReq : IMessage<GetSceneMapInfoCsReq>, IMessage, IEquatable<GetSceneMapInfoCsReq>, IDeepCloneable<GetSceneMapInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetSceneMapInfoCsReq> _parser = new MessageParser<GetSceneMapInfoCsReq>(() => new GetSceneMapInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int SceneIdentifiersFieldNumber = 2;

	private static readonly FieldCodec<SceneIdentifier> _repeated_sceneIdentifiers_codec = FieldCodec.ForMessage(18u, SceneIdentifier.Parser);

	private readonly RepeatedField<SceneIdentifier> sceneIdentifiers_ = new RepeatedField<SceneIdentifier>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSceneMapInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSceneMapInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SceneIdentifier> SceneIdentifiers => sceneIdentifiers_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSceneMapInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSceneMapInfoCsReq(GetSceneMapInfoCsReq other)
		: this()
	{
		sceneIdentifiers_ = other.sceneIdentifiers_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSceneMapInfoCsReq Clone()
	{
		return new GetSceneMapInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSceneMapInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSceneMapInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!sceneIdentifiers_.Equals(other.sceneIdentifiers_))
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
		num ^= sceneIdentifiers_.GetHashCode();
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
		sceneIdentifiers_.WriteTo(ref output, _repeated_sceneIdentifiers_codec);
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
		num += sceneIdentifiers_.CalculateSize(_repeated_sceneIdentifiers_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetSceneMapInfoCsReq other)
	{
		if (other != null)
		{
			sceneIdentifiers_.Add(other.sceneIdentifiers_);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				sceneIdentifiers_.AddEntriesFrom(ref input, _repeated_sceneIdentifiers_codec);
			}
		}
	}
}
