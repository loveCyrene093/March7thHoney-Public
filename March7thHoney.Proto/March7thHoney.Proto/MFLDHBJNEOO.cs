using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MFLDHBJNEOO : IMessage<MFLDHBJNEOO>, IMessage, IEquatable<MFLDHBJNEOO>, IDeepCloneable<MFLDHBJNEOO>, IBufferMessage
{
	private static readonly MessageParser<MFLDHBJNEOO> _parser = new MessageParser<MFLDHBJNEOO>(() => new MFLDHBJNEOO());

	private UnknownFieldSet _unknownFields;

	public const int DGODHIJBMDPFieldNumber = 3;

	private static readonly FieldCodec<HKGDGAJHJPO> _repeated_dGODHIJBMDP_codec = FieldCodec.ForMessage(26u, HKGDGAJHJPO.Parser);

	private readonly RepeatedField<HKGDGAJHJPO> dGODHIJBMDP_ = new RepeatedField<HKGDGAJHJPO>();

	public const int NCJFDBMHINJFieldNumber = 7;

	private HLEIOFJEAKC nCJFDBMHINJ_;

	public const int EFOADCGKLFGFieldNumber = 10;

	private static readonly FieldCodec<CKPEIHOLADP> _repeated_eFOADCGKLFG_codec = FieldCodec.ForMessage(82u, CKPEIHOLADP.Parser);

	private readonly RepeatedField<CKPEIHOLADP> eFOADCGKLFG_ = new RepeatedField<CKPEIHOLADP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MFLDHBJNEOO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MFLDHBJNEOOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HKGDGAJHJPO> DGODHIJBMDP => dGODHIJBMDP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLEIOFJEAKC NCJFDBMHINJ
	{
		get
		{
			return nCJFDBMHINJ_;
		}
		set
		{
			nCJFDBMHINJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CKPEIHOLADP> EFOADCGKLFG => eFOADCGKLFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFLDHBJNEOO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFLDHBJNEOO(MFLDHBJNEOO other)
		: this()
	{
		dGODHIJBMDP_ = other.dGODHIJBMDP_.Clone();
		nCJFDBMHINJ_ = ((other.nCJFDBMHINJ_ != null) ? other.nCJFDBMHINJ_.Clone() : null);
		eFOADCGKLFG_ = other.eFOADCGKLFG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFLDHBJNEOO Clone()
	{
		return new MFLDHBJNEOO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MFLDHBJNEOO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MFLDHBJNEOO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dGODHIJBMDP_.Equals(other.dGODHIJBMDP_))
		{
			return false;
		}
		if (!object.Equals(NCJFDBMHINJ, other.NCJFDBMHINJ))
		{
			return false;
		}
		if (!eFOADCGKLFG_.Equals(other.eFOADCGKLFG_))
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
		num ^= dGODHIJBMDP_.GetHashCode();
		if (nCJFDBMHINJ_ != null)
		{
			num ^= NCJFDBMHINJ.GetHashCode();
		}
		num ^= eFOADCGKLFG_.GetHashCode();
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
		dGODHIJBMDP_.WriteTo(ref output, _repeated_dGODHIJBMDP_codec);
		if (nCJFDBMHINJ_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(NCJFDBMHINJ);
		}
		eFOADCGKLFG_.WriteTo(ref output, _repeated_eFOADCGKLFG_codec);
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
		num += dGODHIJBMDP_.CalculateSize(_repeated_dGODHIJBMDP_codec);
		if (nCJFDBMHINJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NCJFDBMHINJ);
		}
		num += eFOADCGKLFG_.CalculateSize(_repeated_eFOADCGKLFG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MFLDHBJNEOO other)
	{
		if (other == null)
		{
			return;
		}
		dGODHIJBMDP_.Add(other.dGODHIJBMDP_);
		if (other.nCJFDBMHINJ_ != null)
		{
			if (nCJFDBMHINJ_ == null)
			{
				NCJFDBMHINJ = new HLEIOFJEAKC();
			}
			NCJFDBMHINJ.MergeFrom(other.NCJFDBMHINJ);
		}
		eFOADCGKLFG_.Add(other.eFOADCGKLFG_);
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
			case 26u:
				dGODHIJBMDP_.AddEntriesFrom(ref input, _repeated_dGODHIJBMDP_codec);
				break;
			case 58u:
				if (nCJFDBMHINJ_ == null)
				{
					NCJFDBMHINJ = new HLEIOFJEAKC();
				}
				input.ReadMessage(NCJFDBMHINJ);
				break;
			case 82u:
				eFOADCGKLFG_.AddEntriesFrom(ref input, _repeated_eFOADCGKLFG_codec);
				break;
			}
		}
	}
}
