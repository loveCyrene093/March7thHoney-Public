using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightActivityDataChangeScNotify : IMessage<FightActivityDataChangeScNotify>, IMessage, IEquatable<FightActivityDataChangeScNotify>, IDeepCloneable<FightActivityDataChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<FightActivityDataChangeScNotify> _parser = new MessageParser<FightActivityDataChangeScNotify>(() => new FightActivityDataChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ECGLGDKDDIDFieldNumber = 4;

	private static readonly FieldCodec<IFNECJOOIGG> _repeated_eCGLGDKDDID_codec = FieldCodec.ForMessage(34u, IFNECJOOIGG.Parser);

	private readonly RepeatedField<IFNECJOOIGG> eCGLGDKDDID_ = new RepeatedField<IFNECJOOIGG>();

	public const int IMGGPMEOJAJFieldNumber = 10;

	private static readonly MapField<uint, uint>.Codec _map_iMGGPMEOJAJ_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 82u);

	private readonly MapField<uint, uint> iMGGPMEOJAJ_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightActivityDataChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FightActivityDataChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IFNECJOOIGG> ECGLGDKDDID => eCGLGDKDDID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> IMGGPMEOJAJ => iMGGPMEOJAJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightActivityDataChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightActivityDataChangeScNotify(FightActivityDataChangeScNotify other)
		: this()
	{
		eCGLGDKDDID_ = other.eCGLGDKDDID_.Clone();
		iMGGPMEOJAJ_ = other.iMGGPMEOJAJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightActivityDataChangeScNotify Clone()
	{
		return new FightActivityDataChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FightActivityDataChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightActivityDataChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eCGLGDKDDID_.Equals(other.eCGLGDKDDID_))
		{
			return false;
		}
		if (!IMGGPMEOJAJ.Equals(other.IMGGPMEOJAJ))
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
		num ^= eCGLGDKDDID_.GetHashCode();
		num ^= IMGGPMEOJAJ.GetHashCode();
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
		eCGLGDKDDID_.WriteTo(ref output, _repeated_eCGLGDKDDID_codec);
		iMGGPMEOJAJ_.WriteTo(ref output, _map_iMGGPMEOJAJ_codec);
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
		num += eCGLGDKDDID_.CalculateSize(_repeated_eCGLGDKDDID_codec);
		num += iMGGPMEOJAJ_.CalculateSize(_map_iMGGPMEOJAJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightActivityDataChangeScNotify other)
	{
		if (other != null)
		{
			eCGLGDKDDID_.Add(other.eCGLGDKDDID_);
			iMGGPMEOJAJ_.MergeFrom(other.iMGGPMEOJAJ_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 34u:
				eCGLGDKDDID_.AddEntriesFrom(ref input, _repeated_eCGLGDKDDID_codec);
				break;
			case 82u:
				iMGGPMEOJAJ_.AddEntriesFrom(ref input, _map_iMGGPMEOJAJ_codec);
				break;
			}
		}
	}
}
