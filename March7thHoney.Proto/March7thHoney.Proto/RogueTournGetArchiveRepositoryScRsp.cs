using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournGetArchiveRepositoryScRsp : IMessage<RogueTournGetArchiveRepositoryScRsp>, IMessage, IEquatable<RogueTournGetArchiveRepositoryScRsp>, IDeepCloneable<RogueTournGetArchiveRepositoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournGetArchiveRepositoryScRsp> _parser = new MessageParser<RogueTournGetArchiveRepositoryScRsp>(() => new RogueTournGetArchiveRepositoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DAAJNLDNPMBFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_dAAJNLDNPMB_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> dAAJNLDNPMB_ = new RepeatedField<uint>();

	public const int NAOKLDFDGNEFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_nAOKLDFDGNE_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> nAOKLDFDGNE_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournGetArchiveRepositoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournGetArchiveRepositoryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DAAJNLDNPMB => dAAJNLDNPMB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NAOKLDFDGNE => nAOKLDFDGNE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournGetArchiveRepositoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournGetArchiveRepositoryScRsp(RogueTournGetArchiveRepositoryScRsp other)
		: this()
	{
		dAAJNLDNPMB_ = other.dAAJNLDNPMB_.Clone();
		nAOKLDFDGNE_ = other.nAOKLDFDGNE_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournGetArchiveRepositoryScRsp Clone()
	{
		return new RogueTournGetArchiveRepositoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournGetArchiveRepositoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournGetArchiveRepositoryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dAAJNLDNPMB_.Equals(other.dAAJNLDNPMB_))
		{
			return false;
		}
		if (!nAOKLDFDGNE_.Equals(other.nAOKLDFDGNE_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= dAAJNLDNPMB_.GetHashCode();
		num ^= nAOKLDFDGNE_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		dAAJNLDNPMB_.WriteTo(ref output, _repeated_dAAJNLDNPMB_codec);
		nAOKLDFDGNE_.WriteTo(ref output, _repeated_nAOKLDFDGNE_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
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
		num += dAAJNLDNPMB_.CalculateSize(_repeated_dAAJNLDNPMB_codec);
		num += nAOKLDFDGNE_.CalculateSize(_repeated_nAOKLDFDGNE_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournGetArchiveRepositoryScRsp other)
	{
		if (other != null)
		{
			dAAJNLDNPMB_.Add(other.dAAJNLDNPMB_);
			nAOKLDFDGNE_.Add(other.nAOKLDFDGNE_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 32u:
			case 34u:
				dAAJNLDNPMB_.AddEntriesFrom(ref input, _repeated_dAAJNLDNPMB_codec);
				break;
			case 48u:
			case 50u:
				nAOKLDFDGNE_.AddEntriesFrom(ref input, _repeated_nAOKLDFDGNE_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
