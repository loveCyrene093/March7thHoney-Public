using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GENOHIJHCDG : IMessage<GENOHIJHCDG>, IMessage, IEquatable<GENOHIJHCDG>, IDeepCloneable<GENOHIJHCDG>, IBufferMessage
{
	private static readonly MessageParser<GENOHIJHCDG> _parser = new MessageParser<GENOHIJHCDG>(() => new GENOHIJHCDG());

	private UnknownFieldSet _unknownFields;

	public const int IGCJNCKEODGFieldNumber = 6;

	private static readonly FieldCodec<PKGPOMEPEEL> _repeated_iGCJNCKEODG_codec = FieldCodec.ForMessage(50u, PKGPOMEPEEL.Parser);

	private readonly RepeatedField<PKGPOMEPEEL> iGCJNCKEODG_ = new RepeatedField<PKGPOMEPEEL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GENOHIJHCDG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GENOHIJHCDGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PKGPOMEPEEL> IGCJNCKEODG => iGCJNCKEODG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GENOHIJHCDG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GENOHIJHCDG(GENOHIJHCDG other)
		: this()
	{
		iGCJNCKEODG_ = other.iGCJNCKEODG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GENOHIJHCDG Clone()
	{
		return new GENOHIJHCDG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GENOHIJHCDG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GENOHIJHCDG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iGCJNCKEODG_.Equals(other.iGCJNCKEODG_))
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
		num ^= iGCJNCKEODG_.GetHashCode();
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
		iGCJNCKEODG_.WriteTo(ref output, _repeated_iGCJNCKEODG_codec);
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
		num += iGCJNCKEODG_.CalculateSize(_repeated_iGCJNCKEODG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GENOHIJHCDG other)
	{
		if (other != null)
		{
			iGCJNCKEODG_.Add(other.iGCJNCKEODG_);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				iGCJNCKEODG_.AddEntriesFrom(ref input, _repeated_iGCJNCKEODG_codec);
			}
		}
	}
}
