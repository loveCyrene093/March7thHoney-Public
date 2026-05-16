using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OILBFIKHNPK : IMessage<OILBFIKHNPK>, IMessage, IEquatable<OILBFIKHNPK>, IDeepCloneable<OILBFIKHNPK>, IBufferMessage
{
	private static readonly MessageParser<OILBFIKHNPK> _parser = new MessageParser<OILBFIKHNPK>(() => new OILBFIKHNPK());

	private UnknownFieldSet _unknownFields;

	public const int BJNHFEACIOIFieldNumber = 11;

	private static readonly MapField<uint, int>.Codec _map_bJNHFEACIOI_codec = new MapField<uint, int>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForInt32(16u, 0), 90u);

	private readonly MapField<uint, int> bJNHFEACIOI_ = new MapField<uint, int>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OILBFIKHNPK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OILBFIKHNPKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, int> BJNHFEACIOI => bJNHFEACIOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OILBFIKHNPK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OILBFIKHNPK(OILBFIKHNPK other)
		: this()
	{
		bJNHFEACIOI_ = other.bJNHFEACIOI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OILBFIKHNPK Clone()
	{
		return new OILBFIKHNPK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OILBFIKHNPK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OILBFIKHNPK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!BJNHFEACIOI.Equals(other.BJNHFEACIOI))
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
		num ^= BJNHFEACIOI.GetHashCode();
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
		bJNHFEACIOI_.WriteTo(ref output, _map_bJNHFEACIOI_codec);
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
		num += bJNHFEACIOI_.CalculateSize(_map_bJNHFEACIOI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OILBFIKHNPK other)
	{
		if (other != null)
		{
			bJNHFEACIOI_.MergeFrom(other.bJNHFEACIOI_);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bJNHFEACIOI_.AddEntriesFrom(ref input, _map_bJNHFEACIOI_codec);
			}
		}
	}
}
