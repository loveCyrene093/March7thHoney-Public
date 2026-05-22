using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HJBMLDMLANE : IMessage<HJBMLDMLANE>, IMessage, IEquatable<HJBMLDMLANE>, IDeepCloneable<HJBMLDMLANE>, IBufferMessage
{
	private static readonly MessageParser<HJBMLDMLANE> _parser = new MessageParser<HJBMLDMLANE>(() => new HJBMLDMLANE());

	private UnknownFieldSet _unknownFields;

	public const int JKLFMOHICMOFieldNumber = 5;

	private bool jKLFMOHICMO_;

	public const int EAOFJFAFAHOFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_eAOFJFAFAHO_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> eAOFJFAFAHO_ = new RepeatedField<uint>();

	public const int DADDPJDAHBNFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_dADDPJDAHBN_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> dADDPJDAHBN_ = new RepeatedField<uint>();

	public const int GJLHKNGLIKBFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_gJLHKNGLIKB_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> gJLHKNGLIKB_ = new RepeatedField<uint>();

	public const int FFLFIIOMALCFieldNumber = 15;

	private uint fFLFIIOMALC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HJBMLDMLANE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HJBMLDMLANEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JKLFMOHICMO
	{
		get
		{
			return jKLFMOHICMO_;
		}
		set
		{
			jKLFMOHICMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EAOFJFAFAHO => eAOFJFAFAHO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DADDPJDAHBN => dADDPJDAHBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GJLHKNGLIKB => gJLHKNGLIKB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FFLFIIOMALC
	{
		get
		{
			return fFLFIIOMALC_;
		}
		set
		{
			fFLFIIOMALC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJBMLDMLANE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJBMLDMLANE(HJBMLDMLANE other)
		: this()
	{
		jKLFMOHICMO_ = other.jKLFMOHICMO_;
		eAOFJFAFAHO_ = other.eAOFJFAFAHO_.Clone();
		dADDPJDAHBN_ = other.dADDPJDAHBN_.Clone();
		gJLHKNGLIKB_ = other.gJLHKNGLIKB_.Clone();
		fFLFIIOMALC_ = other.fFLFIIOMALC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJBMLDMLANE Clone()
	{
		return new HJBMLDMLANE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HJBMLDMLANE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HJBMLDMLANE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JKLFMOHICMO != other.JKLFMOHICMO)
		{
			return false;
		}
		if (!eAOFJFAFAHO_.Equals(other.eAOFJFAFAHO_))
		{
			return false;
		}
		if (!dADDPJDAHBN_.Equals(other.dADDPJDAHBN_))
		{
			return false;
		}
		if (!gJLHKNGLIKB_.Equals(other.gJLHKNGLIKB_))
		{
			return false;
		}
		if (FFLFIIOMALC != other.FFLFIIOMALC)
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
		if (JKLFMOHICMO)
		{
			num ^= JKLFMOHICMO.GetHashCode();
		}
		num ^= eAOFJFAFAHO_.GetHashCode();
		num ^= dADDPJDAHBN_.GetHashCode();
		num ^= gJLHKNGLIKB_.GetHashCode();
		if (FFLFIIOMALC != 0)
		{
			num ^= FFLFIIOMALC.GetHashCode();
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
		if (JKLFMOHICMO)
		{
			output.WriteRawTag(40);
			output.WriteBool(JKLFMOHICMO);
		}
		eAOFJFAFAHO_.WriteTo(ref output, _repeated_eAOFJFAFAHO_codec);
		dADDPJDAHBN_.WriteTo(ref output, _repeated_dADDPJDAHBN_codec);
		gJLHKNGLIKB_.WriteTo(ref output, _repeated_gJLHKNGLIKB_codec);
		if (FFLFIIOMALC != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FFLFIIOMALC);
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
		if (JKLFMOHICMO)
		{
			num += 2;
		}
		num += eAOFJFAFAHO_.CalculateSize(_repeated_eAOFJFAFAHO_codec);
		num += dADDPJDAHBN_.CalculateSize(_repeated_dADDPJDAHBN_codec);
		num += gJLHKNGLIKB_.CalculateSize(_repeated_gJLHKNGLIKB_codec);
		if (FFLFIIOMALC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FFLFIIOMALC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HJBMLDMLANE other)
	{
		if (other != null)
		{
			if (other.JKLFMOHICMO)
			{
				JKLFMOHICMO = other.JKLFMOHICMO;
			}
			eAOFJFAFAHO_.Add(other.eAOFJFAFAHO_);
			dADDPJDAHBN_.Add(other.dADDPJDAHBN_);
			gJLHKNGLIKB_.Add(other.gJLHKNGLIKB_);
			if (other.FFLFIIOMALC != 0)
			{
				FFLFIIOMALC = other.FFLFIIOMALC;
			}
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
			case 40u:
				JKLFMOHICMO = input.ReadBool();
				break;
			case 48u:
			case 50u:
				eAOFJFAFAHO_.AddEntriesFrom(ref input, _repeated_eAOFJFAFAHO_codec);
				break;
			case 88u:
			case 90u:
				dADDPJDAHBN_.AddEntriesFrom(ref input, _repeated_dADDPJDAHBN_codec);
				break;
			case 104u:
			case 106u:
				gJLHKNGLIKB_.AddEntriesFrom(ref input, _repeated_gJLHKNGLIKB_codec);
				break;
			case 120u:
				FFLFIIOMALC = input.ReadUInt32();
				break;
			}
		}
	}
}
